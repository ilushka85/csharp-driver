﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Cassandra
{
    /// <summary>
    /// A <see cref="ISpeculativeExecutionPolicy"/> that never schedules speculative executions.
    /// </summary>
    public class NoSpeculativeExecutionPolicy : ISpeculativeExecutionPolicy
    {
        private static readonly ISpeculativeExecutionPlan Plan = new NoSpeculativeExecutionPlan();
        public static readonly NoSpeculativeExecutionPolicy Instance = new NoSpeculativeExecutionPolicy();

        private NoSpeculativeExecutionPolicy()
        {
            
        }

        public void Dispose()
        {
            
        }

        public void Initialize(ICluster cluster)
        {
            
        }

        public ISpeculativeExecutionPlan NewPlan(string keyspace, IStatement statement)
        {
            return Plan;
        }

        private class NoSpeculativeExecutionPlan : ISpeculativeExecutionPlan
        {
            public long NextExecution(Host lastQueried)
            {
                return 0L;
            }
        }
    }
}