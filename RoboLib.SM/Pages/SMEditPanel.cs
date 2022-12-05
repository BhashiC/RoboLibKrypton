using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboLib.GUI.Pages;
using TestSM.RGraphics;

namespace RoboLib.SM.Pages
{
    public partial class SMEditPanel : ViewPage
    {
        Label label1;

        public int NumOfCells { get; set; }
        public int CellHeight { get; set; }
        public int CellWidth { get; set; }
        Color GridColor { get; set; }

        public int SelectedCellCol { get; set; }
        public int SelectedCellRow { get; set; }

        Point _selectedCellCenter = new Point();
        public Point SelectedCellCenter { get { return _selectedCellCenter; } }

        Point _selectedCellLocation = new Point();
        public Point SelectedCellLocation { get { return _selectedCellLocation; } }

        public RShapes TranStartCellShape { get; set; }
        public RShapes TranEndCellShape { get; set; }

        public int MouseXPos { get; set; }
        public int MouseYPos { get; set; }

        public List<RShapes> AllShapes { get; set; }

        public List<RArrow> AllArrows { get; set; }

        ContextMenuStrip menue = new ContextMenuStrip();
        ToolStripMenuItem mnuAddState = new ToolStripMenuItem("Add State");
        ToolStripMenuItem mnuDeciState = new ToolStripMenuItem("Add Decision State");
        ToolStripMenuItem mnuRemvItem = new ToolStripMenuItem("Remove Item");
        ToolStripMenuItem mnuStartTran = new ToolStripMenuItem("Start Transition");
        ToolStripMenuItem mnuEndTran = new ToolStripMenuItem("End Transition");
        ToolStripMenuItem mnuRenameState = new ToolStripMenuItem("Rename State");

        RGraphics _lastHighlightedGraphic;
        RShapes _lastSelectedShape;
        Point _mousePoint;
        bool _dragging;
        bool _creatingTransition;

        public SMEditPanel()
        {
            InitializeComponent();

            BackColor = Color.FromArgb(66, 66, 66);//Color.DarkGray; //;
            GridColor = Color.Black;
            Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
            NumOfCells = 12;
            CellHeight = this.ClientSize.Height / NumOfCells;
            CellWidth = this.ClientSize.Width / NumOfCells;

            label1 = new Label() { Location = new Point(0, 0), Width = 120, BorderStyle = BorderStyle.FixedSingle, BackColor = Color.Yellow };
            this.Controls.Add(label1);

            this.Paint += new PaintEventHandler((sender, e) => Form_Paint(sender, e, NumOfCells));
            this.SizeChanged += new EventHandler(Form_Resize);

            mnuAddState.Click += new EventHandler(mnuState_Click);
            mnuDeciState.Click += new EventHandler(mnuDeciState_Click);
            mnuRemvItem.Click += new EventHandler(mnuRemoveItem_Click);
            mnuStartTran.Click += new EventHandler(mnuStartTran_Click);
            mnuEndTran.Click += new EventHandler(mnuEndTran_Click);
            mnuRenameState.Click += new EventHandler(mnuRenameState_Click);

            //Add to main context menu
            menue.Items.AddRange(new ToolStripItem[] { mnuAddState, mnuDeciState, mnuRemvItem, mnuStartTran, mnuEndTran, mnuRenameState });
            //Assign to datagridview
            this.ContextMenuStrip = menue;
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);

            AllShapes = new List<RShapes>();
            AllArrows = new List<RArrow>();
            _lastHighlightedGraphic = new RGraphics();
            _lastHighlightedGraphic = null;
            _lastSelectedShape = new RShapes();
            _lastSelectedShape = null;
            _mousePoint = new Point();
        }

        void DisableMenueItems(RShapes shape)
        {
            mnuAddState.Enabled = false;
            mnuDeciState.Enabled = false;
            mnuRemvItem.Enabled = true;
            mnuStartTran.Enabled = shape is REllipse && AllArrows.Any(x => x.StartShapeName == shape.Text) ? false : true;
            mnuEndTran.Enabled = _creatingTransition && TranStartCellShape  != shape ? true : false;
            mnuRenameState.Enabled = _lastHighlightedGraphic != null ? true : false;
        }

        void EnableMenueItems()
        {
            if (AllShapes.Any(s => s.ColumnOnGrid == SelectedCellCol && s.RowOnGrid == SelectedCellRow))
            {
                mnuAddState.Enabled = false;
                mnuDeciState.Enabled = false;
            }
            else
            {
                mnuAddState.Enabled = true;
                mnuDeciState.Enabled = true;
            }
            mnuRemvItem.Enabled = _lastHighlightedGraphic is RArrow ? true : false;
            mnuStartTran.Enabled = false;
            mnuEndTran.Enabled = false;
            mnuRenameState.Enabled = false;
        }

        void UpdateSelectedCellCordinate()
        {
            _selectedCellCenter.X = CellWidth * (SelectedCellCol - 1) + CellWidth / 2;
            _selectedCellCenter.Y = CellHeight * (SelectedCellRow - 1) + CellHeight / 2;
            _selectedCellLocation.X = (SelectedCellCol - 1) * CellWidth;
            _selectedCellLocation.Y = (SelectedCellRow - 1) * CellHeight;
        }

        RShapes CellOccupiedAndHighlighted()
        {
            foreach (var shape in AllShapes)
            {
                if (shape.LocationOnGrid == _selectedCellLocation && shape.Highlighted)
                {
                    return shape;
                }
            }
            return null;
        }

        #region Menu Items' events
        void mnuState_Click(object sender, EventArgs e)
        {
            UpdateSelectedCellCordinate();
            REllipse ellipse = new REllipse(SelectedCellCol, SelectedCellRow);
            AllShapes.Add(ellipse);
            this.Invalidate();
        }

        void mnuDeciState_Click(object sender, EventArgs e)
        {
            UpdateSelectedCellCordinate();
            RDiamond rectangle = new RDiamond(SelectedCellCol, SelectedCellRow);
            AllShapes.Add(rectangle);
            this.Invalidate();
        }

        void mnuRemoveItem_Click(object sender, EventArgs e)
        {
            var shape = AllShapes.FirstOrDefault(s => s.LocationOnGrid == _selectedCellLocation);
            AllShapes.Remove(shape);

            if (shape != null)
            {
                AllArrows.RemoveAll(x => x.StartShapeName == shape.Text || x.EndShapeName == shape.Text);
            }
            else
            {
                AllArrows.Remove(_lastHighlightedGraphic as RArrow);
            }
            this.Invalidate();
        }

        private void mnuStartTran_Click(object sender, EventArgs e)
        {
            UpdateSelectedCellCordinate();
            if (_lastHighlightedGraphic is RShapes)
            {
                TranStartCellShape = _lastHighlightedGraphic as RShapes;
                _creatingTransition = true;
            }
        }

        private void mnuEndTran_Click(object sender, EventArgs e)
        {
            UpdateSelectedCellCordinate();

            if (_lastHighlightedGraphic is RShapes)
            {
                TranEndCellShape = _lastHighlightedGraphic as RShapes;
                RArrow arrow = new RArrow(TranStartCellShape.ColumnOnGrid, TranStartCellShape.RowOnGrid,
                                      TranEndCellShape.ColumnOnGrid, TranEndCellShape.RowOnGrid, TranStartCellShape.Text, TranEndCellShape.Text);

                AllArrows.Add(arrow);
                _creatingTransition = false;
            }
            this.Invalidate();
        }

        void mnuRenameState_Click(object sender, EventArgs e)
        {

        }
        #endregion

        void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _lastSelectedShape != null)
            {
                _lastSelectedShape.Selected = false;
                _lastSelectedShape = null;
                _dragging = false;
                this.Invalidate();
            }
        }

        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            Form_MouseMove(null, e);

            if (e.Button == MouseButtons.Right)
            {
                var s = CellOccupiedAndHighlighted();
                if (s != null)
                {
                    DisableMenueItems(s);
                }
                else
                {
                    EnableMenueItems();
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _lastSelectedShape = AllShapes.FirstOrDefault(s => s.RowOnGrid == SelectedCellRow && s.ColumnOnGrid == SelectedCellCol);
                if (_lastSelectedShape != null && _lastSelectedShape.Highlighted)
                {
                    _lastSelectedShape.Selected = true;
                    _dragging = true;
                }
            }
        }

        void Form_MouseMove(object sender, MouseEventArgs e)
        {
            MouseXPos = e.X;
            MouseYPos = e.Y;

            _mousePoint.X = MouseXPos;
            _mousePoint.Y = MouseYPos;

            CellHeight = this.ClientSize.Height / NumOfCells;
            CellWidth = this.ClientSize.Width / NumOfCells;
            SelectedCellRow = (int)Math.Ceiling((double)MouseYPos / CellHeight);
            SelectedCellCol = (int)Math.Ceiling((double)MouseXPos / CellWidth);
            label1.Text = "Col = " + SelectedCellCol + " ; Row = " + SelectedCellRow;

            UpdateSelectedCellCordinate();

            if (_dragging)
            {
                if (AllShapes.Any(s => s.ColumnOnGrid == SelectedCellCol && s.RowOnGrid == SelectedCellRow))
                {
                    return;
                }
                _lastSelectedShape.ColumnOnGrid = SelectedCellCol;
                _lastSelectedShape.RowOnGrid = SelectedCellRow;

                AllArrows.FindAll(x => x.StartShapeName == _lastSelectedShape.Text).ToList()
                    .ForEach(a => 
                    {
                        a.StartCellColNum = _lastSelectedShape.ColumnOnGrid;
                        a.StartCellRowNum = _lastSelectedShape.RowOnGrid;
                    });

                AllArrows.FindAll(x => x.EndShapeName == _lastSelectedShape.Text).ToList()
                   .ForEach(a =>
                   {
                       a.EndCellColNum = _lastSelectedShape.ColumnOnGrid;
                       a.EndCellRowNum = _lastSelectedShape.RowOnGrid;
                   });

                this.Invalidate();
            }
            else
            {
                HighlightMouseOver(_mousePoint);
            }
        }

        void HighlightMouseOver(Point p)
        {
            RGraphics mouseOverGraphic = AllShapes.FirstOrDefault(g => g.HitOnShape(p));
            if (mouseOverGraphic == null)
            {
                mouseOverGraphic = AllArrows.FirstOrDefault(a => a.HitOnShape(p));
            }
            //foreach (var s in AllShapes)
            //{
            //    var ar = s.OutgoingArrows.FirstOrDefault(a => a.HitOnShape(p));
            //    if (ar != null) { mouseOverGraphic = ar; }
            //}
            if (mouseOverGraphic != null)
            {
                AllShapes.ForEach(g => g.Highlighted = false);
                AllArrows.ForEach(g => g.Highlighted = false);

                //foreach (var s in AllShapes)
                //{
                //    var ar = s.OutgoingArrows.All(a => a.Highlighted = false);
                //}

                mouseOverGraphic.Highlighted = true;
                if (mouseOverGraphic != _lastHighlightedGraphic)
                {
                    _lastHighlightedGraphic = mouseOverGraphic;
                    if (_lastHighlightedGraphic is RShapes)
                    {
                        (_lastHighlightedGraphic as RShapes).ColumnOnGrid = SelectedCellCol;
                        (_lastHighlightedGraphic as RShapes).RowOnGrid = SelectedCellRow;
                    }
                    this.Invalidate();
                }
            }
            else
            {
                AllShapes.ForEach(g => g.Highlighted = false);
                AllArrows.ForEach(g => g.Highlighted = false);
                //foreach (var s in AllShapes)
                //{
                //    foreach (var ar in s.OutgoingArrows) { ar.Highlighted = false; }
                //}
                if (_lastHighlightedGraphic != null)
                {
                    _lastHighlightedGraphic = null;
                    Invalidate();
                }
            }
        }

        void Form_Resize(object sender, EventArgs e)
        {
            CellHeight = this.ClientSize.Height / NumOfCells;
            CellWidth = this.ClientSize.Width / NumOfCells;
            this.Refresh();
        }

        void Form_Paint(object sender, System.Windows.Forms.PaintEventArgs e, int numOfCells)
        {
            var usrCtr = sender as UserControl;
            DrawGrid(usrCtr, e, numOfCells);

            foreach (var g in AllShapes)
            {
                if (g is RShapes)
                {
                    var gs = g as RShapes;
                    gs.DrawShape(e.Graphics, this);
                    //gs.OutgoingArrows.ForEach(a => a.DrawShape(e.Graphics, this));
                }

            }

            foreach (var a in AllArrows)
            {
                if (a is RArrow)
                {
                    var ar = a as RArrow;
                    ar.DrawShape(e.Graphics, this);
                }
            }
        }

        void DrawGrid(UserControl usrCtr, PaintEventArgs e, int numOfCells)
        {
            Pen pen = new Pen(GridColor) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

            for (int i = 1; i < numOfCells; i++)
            {
                float point1X = 0 + CellWidth * i;
                float point1Y = 0;
                float point2X = 0 + CellWidth * i;
                float point2Y = usrCtr.ClientSize.Height;

                PointF p1 = new PointF(point1X, point1Y);
                PointF p2 = new PointF(point2X, point2Y);
                e.Graphics.DrawLine(pen, p1, p2);
            }

            for (int i = 1; i < numOfCells; i++)
            {
                float point1Y = 0 + CellHeight * i;
                float point1X = 0;
                float point2Y = 0 + CellHeight * i;
                float point2X = usrCtr.ClientSize.Width;

                PointF p1 = new PointF(point1X, point1Y);
                PointF p2 = new PointF(point2X, point2Y);
                e.Graphics.DrawLine(pen, p1, p2);
            }
            pen.Dispose();
        }
    }
}
