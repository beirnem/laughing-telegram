using Notes.Data;
using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
    public partial class App : Application
    {
        static NoteDatabase database;

        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteDatabase(
                        Path.Combine(
                            Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData
                            ), "Notes.db3"));
                }
                return database;
            }
            
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new NotesPage());
        }

        protected override void OnStart()
        {
            // Handle when the app starts
            base.OnStart();
        }

        protected override void OnSleep()
        {
            // Handle when the app sleeps
            base.OnSleep();
        }

        protected override void OnResume()
        {
            // Handle when the app resumes
            base.OnResume();
        }
    }
}