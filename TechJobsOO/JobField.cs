﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            if (value == "" || value == null)
            {
                Value = "Data not available";
            }
            else
            {
                Value = value;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                   Id == jobField.Id;
        }
    }
}
