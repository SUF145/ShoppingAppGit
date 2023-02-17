using System;
using System.Collections.Generic;
namespace ShoppingApp.Services
{
	public class TshirtInfo
	{
		public List<Tshirt> GetDetails()
		{
			return new List<Tshirt>(){
				new Tshirt()
				{ Name = "Trivandrum", Description = "Men Oversized Pure Cotton T-shirt", Price=599, Url="https://www.mydesignation.com/wp-content/uploads/2019/06/trivandrum-tshirt-mydesignation-image-latest.jpg"},

                new Tshirt()
                { Name = "Karnataka", Description = "Men Oversized Pure Cotton T-shirt", Price=499, Url="https://www.mydesignation.com/wp-content/uploads/2019/02/harry-potter-tshirt-glow-in-the-dark-mydesignation-mockup-glow.gif"},

				new Tshirt()
                { Name = "Delhi", Description = "Men Oversized Pure Cotton T-shirt", Price=999, Url="https://www.mydesignation.com/wp-content/uploads/2019/06/but-why-tshirt-mydesignation-image-latest.jpg"}
            };
		}
	}
}

