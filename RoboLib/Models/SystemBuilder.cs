using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.Models
{
    public class SystemBuilder : Singleton<SystemBuilder>
    {
        Robot _robot;
        string _robotName;
        Type _robotType;

        public Robot Robot
        {
            get { return _robot; }
        }

        /// <summary>
        /// Software application name
        /// </summary>
        public string AppName { get; private set; }

        ComponentBase _messageComp = new ComponentBase() { Name = "System" };
        /// <summary>
        /// The Message Component, typically for handling early Machine creation, Initializing, Destroying message
        /// </summary>
        public ComponentBase MessageComp
        {
            get { return _messageComp; }
        }

        /// <summary>
        /// Initialize RoboLib
        /// </summary>
        /// <returns></returns>
        public SystemBuilder InitializeRoboLib()
        {
            // Create a Robot Component 
            _robot = _robot ?? new Robot();
            DisplayMessage.New().Show(_messageComp, "***********************");
            DisplayMessage.New().Show(_messageComp, "Application Starting...");

            #region Load all component types from MLib & the main App together with shared dll
            Assembly app = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
            AppName = Path.GetFileNameWithoutExtension(app.ManifestModule.Name);
            DisplayMessage.New().Show(MessageComp, "Initialize RoboLib. Loading Main Assemblies ...");
            Cache.LoadAssembly(app);
            #endregion

            #region Load all components type from plug in
            DisplayMessage.New().Show(MessageComp, "Initialize RoboLib. Loading Plugins ...");
            if (Directory.Exists(_robot.PluginFolder))
            {
                List<Assembly> listPlugIn = new List<Assembly>();
                foreach (string dll in Directory.GetFiles(_robot.PluginFolder, "*.dll"))
                {
                    listPlugIn.Add(Assembly.LoadFile(dll));
                }

                foreach (Assembly plugIn in listPlugIn)
                {
                    Cache.LoadAssembly(plugIn);
                }
            }
            #endregion

            return this;
        }

        /// <summary>
        /// Define the Robot
        /// </summary>
        /// <param name="robotName"></param>
        /// <param name="robotType"></param>
        /// <returns></returns>
        public SystemBuilder DefineRobot(string robotName, Type robotType)
        {
            _robotName = robotName;
            _robotType = robotType;
            return this;
        }

      
        /// <summary>
        /// Buld the Robot
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Build<T>() where T : Robot
        {
            _robot = Robot.CreateRobot(_robotName, _robotType);
            try
            {
                return (T)_robot;
            }
            catch (Exception ex)
            {
                throw new Exception("Please verify json file, copy from BackupJson if necessary!", ex);
            }
        }
    }
}
