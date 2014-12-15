﻿using System.Collections.Generic;
using System.ComponentModel;
using JuliusSweetland.ETTA.Enums;

namespace JuliusSweetland.ETTA.Models
{
    public interface IKeyboardStateManager : INotifyPropertyChanged
    {
        bool CapturingMultiKeySelection { get; }
        NotifyingConcurrentDictionary<KeyValue, KeyDownStates> KeyDownStates { get; }
        List<string> Suggestions { get; set; }
        int SuggestionsPage { get; }
        int SuggestionsPerPage { get; }
    }
}
