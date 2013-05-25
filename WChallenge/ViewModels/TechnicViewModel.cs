﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WChallenge
{
    public class TechnicViewModel : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _name;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private Uri _videoLink;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public Uri VideoLink
        {
            get
            {
                return _videoLink;
            }
            set
            {
                if (value != _videoLink)
                {
                    _videoLink = value;
                    NotifyPropertyChanged("VideoLink");
                }
            }
        }

        private Uri _imageLink;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public Uri ImageLink
        {
            get
            {
                return _imageLink;
            }
            set
            {
                if (value != _imageLink)
                {
                    _imageLink = value;
                    NotifyPropertyChanged("ImageLink");
                }
            }
        }


        private int _percentageDone;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public int percentageDone
        {
            get
            {
                return _percentageDone;
            }
            set
            {
                if (value != _percentageDone)
                {
                    _percentageDone = value;
                    NotifyPropertyChanged("percentageDone");
                }
            }
        }

        private string _description;
      
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        //private ObservableCollection<StepViewModel> _step;

        //public ObservableCollection<StepViewModel> Step
        //{
        //    get
        //    {
        //        return _step;
        //    }
        //    set
        //    {
        //        if (value != _step)
        //        {
        //            _step = value;
        //            NotifyPropertyChanged("Step");
        //        }
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String percentageDone)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(percentageDone));
            }
        }
    }



    public class StepViewModel : INotifyPropertyChanged
    {
        private string _description;
        
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

      

        private Boolean _done;

        public Boolean Done
        {
            get
            {
                return _done;
            }
            set
            {
                if (value != _done)
                {
                    _done = value;
                    NotifyPropertyChanged("Done");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String percentageDone)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(percentageDone));
            }
        }
    }
}