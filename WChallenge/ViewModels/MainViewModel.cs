﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Microsoft.WindowsAzure.MobileServices;
using WChallenge;


namespace WChallenge
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TechnicViewModel> Items { get; private set; }
        // public ObservableCollection<StepViewModel> Steps { get; private set; }

        public MainViewModel()
        {
            this.Items = new ObservableCollection<TechnicViewModel>();
            // this.Steps = new ObservableCollection<StepViewModel>();
        }


        private string _sampleProperty = "Sample Runtime Property Value";
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }


        public async void LoadData()
        {
            var technic0Steps = new ObservableCollection<StepViewModel>();
            technic0Steps.Add(new StepViewModel() { Description="If a stranger grabbed your hand, raise your other hand", Done=false});
            technic0Steps.Add(new StepViewModel() { Description = "Pull your fingers back", Done = false });
            technic0Steps.Add(new StepViewModel() { Description = "Strike to a nose", Done = false });
            technic0Steps.Add(new StepViewModel() { Description = "If the attacker is larger than you try to strike some other sensitive areas like a face", Done = false });
           
            this.Items.Add(new TechnicViewModel() { Id=0, Step = technic0Steps, Name = "Nose Punch", Description = "Striking the nose.", VideoLink = new Uri("http://www.google.com/url?q=https://www.youtube.com/watch%3Fv%3DAwvfFWDtOZE&usd=2&usg=ALhdy282StejPxMnGxXpl6Gt7ScPUVoakg"), percentageDone = 20, Thumb = new Uri("http://goo.gl/zDsV3")});

            var technicSteps = new ObservableCollection<StepViewModel>();
            technicSteps.Add(new StepViewModel() { Description = "When an arm comes toward you use your forearms to block it putting one hand at a forearm and one hand above the elbow", Done = false });
            technicSteps.Add(new StepViewModel() { Description = "Wrap your hand around the neck", Done = false });
            technicSteps.Add(new StepViewModel() { Description = "Pull it down", Done = false });
            technicSteps.Add(new StepViewModel() { Description = "Grab a wrest", Done = false });
            technicSteps.Add(new StepViewModel() { Description = "Strike with your knee to a stomach or a groin", Done = false });  
      
                 
          this.Items.Add(new TechnicViewModel() { Id=2, Step = technicSteps, Name = "Swing Defence", Description = "Defending if someone swings at you.", percentageDone = 60 });  
 

            var technic1Steps = new ObservableCollection<StepViewModel>();
            technic1Steps.Add(new StepViewModel() { Description = "Stand with your feet about 2 shoulder widths apart", Done = false });
            technic1Steps.Add(new StepViewModel() { Description = "Lift heels behind your toes", Done = false });
            technic1Steps.Add(new StepViewModel() { Description = "Come down, make sure that you keep your feet parallel and your upper body straight and vertical", Done = false });
            technic1Steps.Add(new StepViewModel() { Description = "Put your fists back next to your side", Done = false });
            technic1Steps.Add(new StepViewModel() { Description = "If you get a bear hug from behind do not panick, just drop in your horse stance to get free", Done = false });

            this.Items.Add(new TechnicViewModel()
            {
                Id = 0,
                Name = "Horse Stance",
                Description = "Maecenas praesent accumsan bibendum",
                VideoLink = new Uri("http://www.youtube.com/watch?v=kTSgnaG3mhg"),
                percentageDone = 20,
                ImageLink = new Uri("http://goo.gl/zDsV3"),
                Thumb = new Uri("http://img.youtube.com/vi/kTSgnaG3mhg/0.jpg"),
                Step = technic1Steps
            });

            var technic2Steps = new ObservableCollection<StepViewModel>();
            technic2Steps.Add(new StepViewModel() { Description = "Get into a horse stance", Done = false });
            technic2Steps.Add(new StepViewModel() { Description = "Open your hands", Done = false });
            technic2Steps.Add(new StepViewModel() { Description = "Push you heels a little forward and pull fingers a little back", Done = false });
            technic2Steps.Add(new StepViewModel() { Description = "Hit an attacker to the nose with one hand", Done = false });
            technic2Steps.Add(new StepViewModel() { Description = "Hit with the ohther hand", Done = false });
          

            this.Items.Add(new TechnicViewModel()
            {
                Id = 1,
                Name = "Palm heel strike to nose",
                Description = "Maecenas praesent accumsan bibendum",
                VideoLink = new Uri("http://www.youtube.com/watch?v=SZO9iX1vRsM"),
                percentageDone = 20,
                ImageLink = new Uri("http://goo.gl/zDsV3"),
                Thumb = new Uri("http://img.youtube.com/vi/SZO9iX1vRsM/0.jpg"),
                Step = technic2Steps
            });


            var technic3Steps = new ObservableCollection<StepViewModel>();
            technic3Steps.Add(new StepViewModel() { Description = "If an attacker has his hands around your neck bring your left hand over his hand.", Done = false });
            technic3Steps.Add(new StepViewModel() { Description = "Grab his wrist", Done = false });
            technic3Steps.Add(new StepViewModel() { Description = "Use your elbow to push down his elbow", Done = false });
            technic3Steps.Add(new StepViewModel() { Description = "Bring your right hand in a circle twisting your body", Done = false });
            technic3Steps.Add(new StepViewModel() { Description = "Use your elbow to strike in a face area", Done = false });
            
            this.Items.Add(new TechnicViewModel() { Id = 3, Step =  technic3Steps , Name = "Choke Escape", Description = "Escaping from a choke", percentageDone = 80 });

            var technic4Steps = new ObservableCollection<StepViewModel>();
            technic4Steps.Add(new StepViewModel() { Description = "Spread your feet apart.", Done = false });
            technic4Steps.Add(new StepViewModel() { Description = "Bend your knees.", Done = false });
            technic4Steps.Add(new StepViewModel() { Description = "Take your hands back.", Done = false });
            technic4Steps.Add(new StepViewModel() { Description = "Lift your knee.", Done = false });
            technic4Steps.Add(new StepViewModel() { Description = "Extend your leg.", Done = false });
            technic4Steps.Add(new StepViewModel() { Description = "Bring your knee back..", Done = false });
            technic4Steps.Add(new StepViewModel() { Description = "Come down.", Done = false });

            this.Items.Add(new TechnicViewModel() { Id = 4, Step = technic4Steps, Name = "Basic Kick",  percentageDone = 80, VideoLink=new Uri("http://www.youtube.com/watch?v=yKEy3tEhCog") });


            var technic5Steps = new ObservableCollection<StepViewModel>();
            technic5Steps.Add(new StepViewModel() { Description = "Take your shoes off.", Done = false });
            technic5Steps.Add(new StepViewModel() { Description = " Put  the shoe on your hand to protect yourself around your wrist", Done = false });
            technic5Steps.Add(new StepViewModel() { Description = "Turn the shoe around and use it with your hammer strike (to the eye, groin)", Done = false });
            technic5Steps.Add(new StepViewModel() { Description = "Before going to your car always take your keys out of the purse, so that you are not fumbling for them", Done = false });
            technic5Steps.Add(new StepViewModel() { Description = "Carry a pepper spray on your keychain and in case of an attack shoot at a safe distance", Done = false });
            technic5Steps.Add(new StepViewModel() { Description = "Carry a pepper spray on your keychain and in case of an attack shoot at a safe distance", Done = false });

            this.Items.Add(new TechnicViewModel() { Id = 5, Step = technic5Steps, Name = "Self defence with heels and a keychain", Description = "Using everyday objects for defence.", VideoLink = new Uri("http://www.youtube.com/watch?v=IYjd0pTsqyw"), percentageDone = 80 });


            this.IsDataLoaded = true;
        }

        // public class Item { public int Id { get; set; } public string Text { get; set; } }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}