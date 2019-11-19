using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HoWestPost.Domain
{
    public class DeliveryProcessor : INotifyPropertyChanged
    {
        private List<Delivery> deliveriesInProgress;
        public List<Delivery> DeliveriesInProgress
        {
            get { return deliveriesInProgress; }
            set
            {
                deliveriesInProgress = value;
                RaisePropertyChanged(nameof(DeliveriesInProgress));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
