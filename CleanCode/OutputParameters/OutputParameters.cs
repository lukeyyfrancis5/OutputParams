﻿using CleanCode.Comments;
using System;
using System.Collections.Generic;

namespace CleanCode.OutputParameters
{
    public class GetCustomerResult
    {
        public IEnumerable<Customer> Customers { get; set; }
        public int TotalCount { get; set; }
    }

    public class OutputParameters
    {
        public void DisplayCustomers()
        {
            var result = GetCustomers(pageIndex: 1);

            Console.WriteLine("Total customers: " + result.TotalCount);
            foreach (var c in result.Customers)
                Console.WriteLine(c);
        }

        public GetCustomerResult GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return new GetCustomerResult() {Customers = new List<Customer>(), TotalCount = totalCount };
        }
    }
}
