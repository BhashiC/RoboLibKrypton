using ComponentFactory.Krypton.Toolkit;
using Robo3DWpf;
using RoboJarvis.Comp.Motion;
using RoboJarvis.Comp.PathPlan;
using RoboJarvis.Pages;
using RoboLib;
using RoboLib.Extensions;
using RoboLib.GUI;
using RoboLib.GUI.Pages;
using RoboLib.Models;
using RoboLib.Models.Communication;
using RoboLib.SM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboJarvis
{
    public partial class Form1 : Form1Base
    {
        JarvisRobot _robot;
        Robo3DUserControl _robo3DUserControl;
        PathPlanner _pathPlanner;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void DefineRobot()
        {
            base.DefineRobot();

            _robot = SystemBuilder.Instance.InitializeRoboLib().DefineRobot(CompNames.Jarvis.ToString(), typeof(JarvisRobot)).Build<JarvisRobot>();
            var controller1 = ComponentBuilder.DefineComponent(_robot, CompNames.Joint1.ToString(), typeof(MKSAxis))
                .WithFirstTimeInit<MKSAxis>(x => x.SetDefaultLimits())
                .WithPluginType(PlugInTypes.MKS42A57A.ToString()).Build<MKSAxis>();
            var controller2 = ComponentBuilder.DefineComponent(_robot, CompNames.Joint2.ToString(), typeof(MKSAxis))
                .WithFirstTimeInit<MKSAxis>(x => x.SetDefaultLimits())
                .WithPluginType(PlugInTypes.MKS42A57A.ToString()).Build<MKSAxis>();
            var controller3 = ComponentBuilder.DefineComponent(_robot, CompNames.Joint3.ToString(), typeof(MKSAxis))
                .WithFirstTimeInit<MKSAxis>(x => x.SetDefaultLimits())
                .WithPluginType(PlugInTypes.MKS42A57A.ToString()).Build<MKSAxis>();
            var controller4 = ComponentBuilder.DefineComponent(_robot, CompNames.Joint4.ToString(), typeof(MKSAxis))
                .WithFirstTimeInit<MKSAxis>(x => x.SetDefaultLimits())
                .WithPluginType(PlugInTypes.MKS42A57A.ToString()).Build<MKSAxis>();
            var controller5 = ComponentBuilder.DefineComponent(_robot, CompNames.Joint5.ToString(), typeof(MKSAxis))
                .WithFirstTimeInit<MKSAxis>(x => x.SetDefaultLimits())
                .WithPluginType(PlugInTypes.MKS42A57A.ToString()).Build<MKSAxis>();
            var controller6 = ComponentBuilder.DefineComponent(_robot, CompNames.Joint6.ToString(), typeof(MKSAxis))
                .WithFirstTimeInit<MKSAxis>(x => x.SetDefaultLimits())
                .WithPluginType(PlugInTypes.MKS42A57A.ToString()).Build<MKSAxis>();
            ComponentBuilder.DefineComponent(controller1, CompNames.J1Rs232.ToString(), typeof(RS232)).Build<RS232>();
            ComponentBuilder.DefineComponent(controller2, CompNames.J2Rs232.ToString(), typeof(RS232)).Build<RS232>();
            ComponentBuilder.DefineComponent(controller3, CompNames.J3Rs232.ToString(), typeof(RS232)).Build<RS232>();
            ComponentBuilder.DefineComponent(controller4, CompNames.J4Rs232.ToString(), typeof(RS232)).Build<RS232>();
            ComponentBuilder.DefineComponent(controller5, CompNames.J5Rs232.ToString(), typeof(RS232)).Build<RS232>();
            ComponentBuilder.DefineComponent(controller6, CompNames.J6Rs232.ToString(), typeof(RS232)).Build<RS232>();
            _pathPlanner = ComponentBuilder.DefineComponent(_robot, CompNames.PathPlan.ToString(), typeof(PathPlanner)).Build<PathPlanner>();
            ComponentBuilder.DefineComponent(_robot, "RobotSM", typeof(StateMachine)).Build<StateMachine>();


            _robot.InitializeRecurse();         
        }

        protected override void DefineBinding()
        {
            base.DefineBinding();
            
            toolStripComboBoxTheme.ComboBox.DataSource = Enum.GetValues(typeof(Themes));
            toolStripComboBoxTheme.SelectedItem = _robot.GUITheme;
            toolStripComboBoxTheme.ComboBox.SelectionChangeCommitted += new EventHandler(toolStripComboBoxTheme_SelectionChangeCommitted);

            // Create the WPF UserControl
            _robo3DUserControl = new Robo3DUserControl();
            
            // Assign the WPF UserControl to the ElementHost control's
            // Child property.
            elementHost1.Child = _robo3DUserControl;
            _robot.RoboModelWpfControl = _robo3DUserControl;

            robotTrackBarPanel1.PerformBinding(_robot);
            pathPlanPage1.PerformBinding(_pathPlanner);
        }

        void toolStripComboBoxTheme_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Enum.TryParse((sender as ComboBox).SelectedValue.ToString(), out Themes theme))
            {
                SetTheme(theme);
            }

            // By selecting another gui component after selecting item in the ComboBox, 
            // the selected item no longer highlighted 
            toolStrip1.Select();
        }

        void SetTheme(Themes theme)
        {
            if (theme == Themes.Light)
            {
                this.PaletteMode = PaletteMode.Office2010Silver;
                kryptonPalette1.BasePaletteMode = PaletteMode.Office2010Silver;
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            }
            else if (theme == Themes.Ocean)
            {
                this.PaletteMode = PaletteMode.Office2010Blue;
                kryptonPalette1.BasePaletteMode = PaletteMode.Office2010Blue;
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            }
            else
            {
                this.PaletteMode = PaletteMode.SparkleOrange;
                kryptonPalette1.BasePaletteMode = PaletteMode.SparkleOrange;
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            }
            _robot.GUITheme = theme;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnForm1Closing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnForm1Load();
            SetTheme(_robot.GUITheme);
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            using (var frm = new SettingsForm())
            {
                frm.ShowDialog();
            }
        }

        private void toolStripButtonJoints_Click(object sender, EventArgs e)
        {
            using (var frm = new KryptonForm()
            {
                Width = 958,
                Height = 870,
                Text = "Joint Control Page",
                ShowIcon = false,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                BackColor = Color.Black,//.FromArgb(62, 62, 66),
                MinimizeBox = false,
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow,
                AutoScroll = true
            })
            {
                JointControlPage jointPage = new JointControlPage() { Dock = DockStyle.Fill };
                jointPage.PerformBinding(_robot);
                frm.AddAndBringToFront<JointControlPage>(jointPage);
                frm.ShowDialog();
            }
        }

        private void toolStripButtonFixToFrame_Click(object sender, EventArgs e)
        {
            _robo3DUserControl.SetDefaultView();
        }
    }
}
