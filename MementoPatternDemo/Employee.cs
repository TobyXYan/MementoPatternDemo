using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternDemo
{
	public interface IEmployee
	{

	}

	public class EmployeeClone: IEmployee
	{
		private string firstName;
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
	}
    public class Employee: IEmployee
	{
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
		private EmployeeClone original;

		public EmployeeClone Original
		{
			get { return original; }
			set { original = value; }
		}

		public void Revert()
		{
			LastName  = Original.LastName;
			FirstName = Original.FirstName;
			Address   = Original.Address;
		}

		public bool IsModified()
		{
			return !(FirstName.Equals(Original.FirstName)&& LastName.Equals(Original.LastName) && Address.Equals(Original.Address));
		}

		public void SyncToOriginal()
		{
			if (null == Original)
				Original = new EmployeeClone();
			Original.LastName  = LastName;
			Original.FirstName = FirstName;
			Original.Address   = Address;
		}

	}
}
