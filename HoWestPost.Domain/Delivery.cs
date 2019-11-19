using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HoWestPost.Domain
{
    public class Delivery : INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        public PackageType PackageType { get; set; }
        public bool IsPriority { get; set; }
        private int TravelTime { get; set; }
        public int ElapsedTime { get; set; }
        public int Progress { get { return ElapsedTime / TravelTime * 100; } }
        public int TimeRemaining { get { return TravelTime - ElapsedTime; } }

        public event PropertyChangedEventHandler PropertyChanged;
        public Delivery(PackageType packageType, int travelTimeToDestination, bool isPriority = false)
        {
            Id = new Guid();

            PackageType = packageType;
            TravelTime = travelTimeToDestination;
            IsPriority = isPriority;
        }

        private void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
