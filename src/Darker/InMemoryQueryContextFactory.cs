﻿namespace Darker
{
    public class InMemoryQueryContextFactory : IQueryContextFactory
    {
        public IQueryContext Create() => new QueryContext();
    }
}