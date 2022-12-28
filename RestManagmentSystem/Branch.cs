using System;
namespace RestManagmentSystem
{
	public class Branch
	{
		public List<Table> tables = new List<Table>();
		public String branchLocation { set; get; }
		int id;
		public Branch()
		{
		}
		public void addTable(Table table)
		{
			tables.Add(table);
		}
        public Table GetTable(int id)
        {
			return tables[id];
        }
		
    }
}