This is a copy-paste of Avalonia's ComboBox (or at least, the fluent control theme).
And then I hacked out the normal selected item presenter,
and hacked in a TextBox.

The idea is you can either type your own value, or choose from the list.
I plan to use this where the list might be very, very long.
I'd use the AutoCompleteBox, except I like how the ComboBox feels.
Also it seemed easier to jam a TextBox into a ComboBox
than to jam a ToggleButton for the dropdown into an AutoCompleteBox.
