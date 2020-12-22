using System;
using System.Collections.Generic;

namespace VideoAppCore.Models
{
    // [4 - 3] 리포지토리 클래스 : Full ORM 인 EfCore을 사용하여 CRUD 구현

    public class VideoRepositroyEfCore : IVideoRepository
    {
        public Video AddVideo(Video model)
        {
            throw new NotImplementedException();
        }

        public Video GetVideoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Video> GetVideos()
        {
            throw new NotImplementedException();
        }

        public void RemoveVideo(int id)
        {
            throw new NotImplementedException();
        }

        public Video UpdateVideo(Video model)
        {
            throw new NotImplementedException();
        }
    }
}
