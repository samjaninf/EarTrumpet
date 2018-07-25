﻿using EarTrumpet_Actions.DataModel.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarTrumpet_Actions.ViewModel.Conditions
{
    class DefaultPlaybackDeviceConditionViewModel : PartViewModel
    {
        public DeviceViewModel Device { get; }

        public OptionViewModel Option { get; }

        public DefaultPlaybackDeviceConditionViewModel(DefaultPlaybackDeviceCondition condition) : base(condition)
        {
            Option = new OptionViewModel(condition);
            Option.PropertyChanged += (_, __) => UpdateDescription();
            Device = new DeviceViewModel(condition);
            Device.PropertyChanged += (_, __) => UpdateDescription();
            UpdateDescription();
        }
    }
}
