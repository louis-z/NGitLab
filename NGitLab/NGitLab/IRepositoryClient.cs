﻿using System;
using System.Collections.Generic;
using System.IO;
using NGitLab.Models;

namespace NGitLab
{
    public interface IRepositoryClient
    {
        ITagClient Tags { get; }
        IEnumerable<Tree> Tree { get; }
        IEnumerable<Tree> GetTree(string path);
        void GetRawBlob(string sha, Action<Stream> parser);
        void GetArchive(Action<Stream> parser);

        IEnumerable<Commit> Commits { get; }
        IContributorClient Contributors { get; }

        /// <summary>
        /// Gets all the commits of the specified branch/tag.
        /// </summary>
        IEnumerable<Commit> GetCommits(string refName, int maxResults = 0);

        Commit GetCommit(Sha1 sha);
        IEnumerable<Diff> GetCommitDiff(Sha1 sha);

        IFilesClient Files { get; }

        IBranchClient Branches { get; }

        IProjectHooksClient ProjectHooks { get; }
    }
}