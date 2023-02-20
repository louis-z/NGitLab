using System;

namespace NGitLab.Models
{
    /// <summary>
    /// Allows to use more advanced GitLab queries for getting issues
    /// </summary>
    public class EventQuery
    {
        private DateTime? _before;
        private DateTime? _after;

        /// <summary>
        /// Include only events of a particular action type
        /// </summary>
        [QueryParameter("action")]
        public EventAction? Action { get; set; }

        /// <summary>
        /// Include only events of a particular target type
        /// </summary>
        [QueryParameter("target_type")]
        public EventTargetType? Type { get; set; }

        /// <summary>
        /// Include only events created before a particular date.
        /// </summary>
        [QueryParameter("before")]
        public DateTime? Before
        {
            get => _before?.Date;
            set => _before = value;
        }

        /// <summary>
        /// Include only events created after a particular date.
        /// </summary>
        [QueryParameter("after")]
        public DateTime? After
        {
            get => _after?.Date;
            set => _after = value;
        }

        /// <summary>
        /// Include all events across a user’s projects.
        /// </summary>
        [QueryParameter("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Sort events in asc or desc order by created_at. Default is desc
        /// </summary>
        [QueryParameter("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// Specifies how many records per page (GitLab supports a maximum of 100 items per page and defaults to 20).
        /// </summary>
        [QueryParameter("per_page")]
        public int? PerPage { get; set; }
    }
}
