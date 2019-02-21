using System;
using Xunit;
using LeftJoinApp;
using hashtablesApp.Classes;
using System.Collections.Generic;

namespace LeftJoinTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanLeftJoinTwoMatchingTables()
        {
            Hashtable table1 = new Hashtable();
            table1.Add("Funny", "Hilarious");
            table1.Add("Feline", "Cat");
            Hashtable table2 = new Hashtable();
            table2.Add("Funny", "Serious");
            table2.Add("Feline", "Dog");
            string[] str1 = { "Funny", "Hilarious", "Serious" };
            string[] str2 = { "Feline", "Cat", "Dog" };

            List<string[]> expected = new List<string[]>();
            expected.Add(str2);
            expected.Add(str1);

            Assert.Equal(expected, Program.LeftJoin(table1, table2));           
        }

        [Fact]
        public void CanLeftJoinTwoIfTable2IsEmpty()
        {
            Hashtable table1 = new Hashtable();
            table1.Add("Funny", "Hilarious");
            table1.Add("Feline", "Cat");
            Hashtable table2 = new Hashtable();
            string[] str1 = { "Funny", "Hilarious", null };
            string[] str2 = { "Feline", "Cat", null };

            List<string[]> expected = new List<string[]>();
            expected.Add(str2);
            expected.Add(str1);

            Assert.Equal(expected, Program.LeftJoin(table1, table2));
        }
        [Fact]
        public void CanLeftJoinIfFirstTableIsNull()
        {
            Hashtable table1 = new Hashtable();
            Hashtable table2 = new Hashtable();
            table2.Add("Funny", "Serious");
            table2.Add("Feline", "Dog");

            List<string[]> expected = new List<string[]>();

            Assert.Equal(expected, Program.LeftJoin(table1, table2));
        }

        [Fact]
        public void CanLeftJoinTwoTablesAreUnBalanced()
        {
            Hashtable table1 = new Hashtable();
            table1.Add("Funny", "Hilarious");
            table1.Add("Feline", "Cat");
            table1.Add("Cute", "Adorable");
            Hashtable table2 = new Hashtable();
            table2.Add("Funny", "Serious");
            table2.Add("Feline", "Dog");
            table2.Add("Near", "Far");
            string[] str1 = { "Funny", "Hilarious", "Serious" };
            string[] str2 = { "Feline", "Cat", "Dog" };
            string[] str3 = { "Cute", "Adorable", null };

            List<string[]> expected = new List<string[]>();
            expected.Add(str3);
            expected.Add(str2);
            expected.Add(str1);

            Assert.Equal(expected, Program.LeftJoin(table1, table2));
        }

    }
}
