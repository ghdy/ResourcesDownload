using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesDownload.Core
{
    public interface ICategoryParser
    {
        int PageCount { get;}

        IEnumerable<EpisodeInfo> GetEpisodes(int page);
    }
}
