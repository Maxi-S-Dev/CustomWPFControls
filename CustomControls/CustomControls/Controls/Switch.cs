using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;

namespace CustomControls.Controls
{
    public class Switch : Control
    {
        public static readonly DependencyProperty ToggledProperty = DependencyProperty.Register("Toggled", typeof(bool), typeof(Switch), new PropertyMetadata(false));
        public static readonly RoutedEvent ToggleSwitchedEvent = EventManager.RegisterRoutedEvent("ToggleSwitched", RoutingStrategy.Bubble, typeof(RoutedEventArgs), typeof(Switch));
        
        public bool Toggled
        {
            get => (bool)GetValue(ToggledProperty);
            set
            {
                SetValue(ToggledProperty, value);
                Trace.WriteLine("Toggled");
                UpdateVisualState();
            }
        }

        private event RoutedEventHandler ToggleSwitched
        {
            add 
            {
                AddHandler(ToggleSwitchedEvent, value);
            }
            remove 
            { 
                RemoveHandler(ToggleSwitchedEvent, value);
            }
        }

        void OnToggled()
        {
            RaiseEvent(new RoutedEventArgs(ToggleSwitchedEvent, this));
            Toggled = !Toggled;
        }

        static Switch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(typeof(Switch)));
            
        }

        void UpdateVisualState()
        {
            VisualStateManager.GoToState(this, "Toggled", Toggled);
            VisualStateManager.GoToState(this, "UnToggled", !Toggled);
        }
    }
}       
