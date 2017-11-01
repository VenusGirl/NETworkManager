﻿using Heijden.DNS;
using NETworkManager.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NETworkManager.ViewModels.Settings
{
    public class SettingsApplicationRemoteDesktopViewModel : ViewModelBase
    {
        #region Variables
        private bool _isLoading = true;

        private bool _redirectClipboard;
        public bool RedirectClipboard
        {
            get { return _redirectClipboard; }
            set
            {
                if (value == _redirectClipboard)
                    return;

                if (!_isLoading)
                    SettingsManager.Current.RemoteDesktop_RedirectClipboard = value;

                _redirectClipboard = value;
                OnPropertyChanged();
            }
        }

        private bool _redirectDevices;
        public bool RedirectDevices
        {
            get { return _redirectDevices; }
            set
            {
                if (value == _redirectDevices)
                    return;

                if (!_isLoading)
                    SettingsManager.Current.RemoteDesktop_RedirectDevices = value;

                _redirectDevices = value;
                OnPropertyChanged();
            }
        }

        private bool _redirectDrives;
        public bool RedirectDrives
        {
            get { return _redirectDrives; }
            set
            {
                if (value == _redirectDrives)
                    return;

                if (!_isLoading)
                    SettingsManager.Current.RemoteDesktop_RedirectDrives = value;

                _redirectDrives = value;
                OnPropertyChanged();
            }
        }

        private bool _redirectPorts;
        public bool RedirectPorts
        {
            get { return _redirectPorts; }
            set
            {
                if (value == _redirectPorts)
                    return;

                if (!_isLoading)
                    SettingsManager.Current.RemoteDesktop_RedirectPorts = value;

                _redirectPorts = value;
                OnPropertyChanged();
            }
        }

        private bool _redirectSmartcards;
        public bool RedirectSmartcards
        {
            get { return _redirectSmartcards; }
            set
            {
                if (value == _redirectSmartcards)
                    return;

                if (!_isLoading)
                    SettingsManager.Current.RemoteDesktop_RedirectSmartcards = value;

                _redirectSmartcards = value;
                OnPropertyChanged();
            }
        }

        private bool _redirectPrinters;
        public bool RedirectPrinters
        {
            get { return _redirectPrinters; }
            set
            {
                if (value == _redirectPrinters)
                    return;

                if (!_isLoading)
                    SettingsManager.Current.RemoteDesktop_RedirectPrinters = value;

                _redirectPrinters = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constructor, load settings
        public SettingsApplicationRemoteDesktopViewModel()
        {
            LoadSettings();

            _isLoading = false;
        }

        private void LoadSettings()
        {
            RedirectClipboard = SettingsManager.Current.RemoteDesktop_RedirectClipboard;
            RedirectDevices = SettingsManager.Current.RemoteDesktop_RedirectDevices;
            RedirectDrives = SettingsManager.Current.RemoteDesktop_RedirectDrives;
            RedirectPorts = SettingsManager.Current.RemoteDesktop_RedirectPorts;
            RedirectSmartcards = SettingsManager.Current.RemoteDesktop_RedirectSmartcards;
            RedirectPrinters = SettingsManager.Current.RemoteDesktop_RedirectPrinters;
        }
        #endregion
    }
}