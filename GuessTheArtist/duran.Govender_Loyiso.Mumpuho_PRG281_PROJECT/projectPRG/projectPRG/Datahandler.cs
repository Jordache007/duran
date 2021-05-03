using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectPRG
{
	class Datahandler
	{
		List<Users> people = new List<Users>();
		public List<Users> Reader()
		{

			try
			{
				StreamReader ss = new StreamReader("users.txt", true);
				string line = ss.ReadLine();
				while (line != null)
				{
					string[] array = new string[2];
					array = line.Split('#');
					people.Add(new Users(array[0], array[1]));
					line = ss.ReadLine();


				}
				ss.Close();
			}
			catch (IOException ee)
			{
				Console.Write(ee);
			}
			return people;
		}
		public void writer(string username, string password)
		{
			StreamWriter sw = new StreamWriter("users.txt", true);
			using (sw)
			{
				string line = username + "#" + password;
				sw.WriteLine(line);


			}
			sw.Close();
		}
	}
}
