
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree.Models;

public class StartUp
{
    public static void Main(string[] args)
    {
		List<Person> people = new List<Person>();
		List<Product> listProduct = new List<Product>();

		try
		{
			string[] nameMoneyPairs = Console.ReadLine()
				.Split(";", StringSplitOptions.RemoveEmptyEntries);

			foreach (var nameMoneyPair in nameMoneyPairs)
			{
				string[] nameMoney = nameMoneyPair.Split("=", StringSplitOptions.RemoveEmptyEntries);

				Person person = new Person(nameMoney[0], decimal.Parse(nameMoney[1]));

				people.Add(person);
			}
            string[] productPairs = Console.ReadLine()
            .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var productPair in productPairs)
            {
                string[] productCost = productPair.Split("=", StringSplitOptions.RemoveEmptyEntries);

                Product product = new Product(productCost[0], decimal.Parse(productCost[1]));

                listProduct.Add(product);
            }
        }
		catch (ArgumentException ex)
		{
			Console.WriteLine(ex.Message);
			return;
		}

		string input;
		while((input = Console.ReadLine())!= "END")
		{
			string[] personProduct = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

			string personName = personProduct[0];
			string productName = personProduct[1];

			Person person = people.FirstOrDefault(x => x.Name == personName);
			Product product = listProduct.FirstOrDefault(x => x.Name == productName);

			if(person != null && product != null)
			{
				Console.WriteLine(person.Add(product));
			}
		}
		Console.WriteLine(string.Join(Environment.NewLine,people));
    }
}
