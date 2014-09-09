<Query Kind="Program" />

void Main()
{
	List<Customer> customers = new List<Customer>
	{
		new Customer
		{
			Id = 1,
			Name = "Luis"
		},
		new Customer
		{
			Id = 2,
			Name = "Jorge"
		},
		new Customer
		{
			Id = 1,
			Name = "Luis"
		},
	};
	
	var distinctCustomers = customers.GroupBy(c => c.Id).Select(c => c.First());
	
	distinctCustomers.Dump();
}

class Customer
{
	public int Id { get; set; }
	public string Name { get; set; }
}
