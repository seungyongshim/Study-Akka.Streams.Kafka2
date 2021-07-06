namespace WebApp.Model
{
    using System.Collections.Generic;
    using DotNetCore.Domain;
    using WebApp.Vo;

    public class Team : Entity<Team>
    {
        public IList<Name> Members { get; init; }
    }
}
