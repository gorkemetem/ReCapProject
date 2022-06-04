using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintanenceTime = "System is in maintenance";
        public static string CarAdded = "New Car Added";
        public static string CarRemoved = "Car Deleted";
        public static string CarUpdated = "Car Updated";
        public static string CarsListed = "Cars Listed";
        public static string CarNameInvalid = "Car Name is Invalid";
        public static string BrandAdded = "New Brand Added";
        public static string BrandRemoved = "Brand Deleted";
        public static string BrandUpdated = "Brand Updated";
        public static string BrandsListed = "Brands Listed";
        public static string ColorAdded = "New Color Added";
        public static string ColorRemoved = "Color Deleted";
        public static string ColorUpdated = "Color Updated";
        public static string ColorsListed = "ColorsListed";
        public static string ReturnDateError = "Rental Failed";
        public static string RentalAdded = "Rental Successful.";
        public static string CarCountOfBrandError = "A brand cannot add more than 10 cars";
        public static string CarNameAlreadyExists = "There is already a car with this name";
        public static string BrandLimitExceded = "Limit Reached";
        public static string AuthorizationDenied = "You Are Not Authorized";
    }
}
