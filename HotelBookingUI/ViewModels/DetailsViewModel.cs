using System;
using System.Collections.ObjectModel;
using HotelBookingUI.Models;

namespace HotelBookingUI.ViewModels
{
	public class DetailsViewModel
	{
        private ObservableCollection<Reviews> reviews;
        private ObservableCollection<Services> service;

        public ObservableCollection<Reviews> Reviews
        {
            get { return reviews; }
            set { this.reviews = value; }
        }

        public ObservableCollection<Services> Services
        {
            get { return service; }
            set { this.service = value; }
        }

        public DetailsViewModel()
		{
            reviews = new ObservableCollection<Reviews>();
            reviews.Add(new Reviews { Picture = "model1" });
            reviews.Add(new Reviews { Picture = "model2" });
            reviews.Add(new Reviews { Picture = "model3" });
            reviews.Add(new Reviews { Picture = "model4" });

            service = new ObservableCollection<Services>();
            service.Add(new Services { Picture = "wifi", Title = "Wifi" });
            service.Add(new Services { Picture = "pool", Title = "Pool" });
            service.Add(new Services { Picture = "dryer", Title = "Dryer" });
        }
    }
}

