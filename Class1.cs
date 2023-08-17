
/// <summary>
/// Summary description for Class1
/// </summary>
using System;
using System.Collections;
public class Class1
{

		//
		// TODO: Add constructor logic here
		//
		public int AddNumber(int i , int j , Hashtable h)
        {
			return i + j + SetYear() + h.Count;
        }

		public int SetYear()
		{
			return int.Parse(DateTime.Now.Month.ToString());
		}

		private Hashtable SetHashtable()
		{
			Hashtable ht = new Hashtable();
			ht.Add("001", "a");
			ht.Add("002", "b");
			ht.Add("003", "c");
			ht.Add("004", "d");
			ht.Add("005", "e");
			ht.Add("006", "f");
			ht.Add("007", "g");
			return ht;
		}
	
}
