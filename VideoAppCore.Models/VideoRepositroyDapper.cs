using System;
using System.Collections.Generic;

namespace VideoAppCore.Models
{
    // [4 - 2] 리포지토리 클래스 : Micro ORM Dapper 사용하여 CRUD 구현
    public class VideoRepositroyDapper : IVideoRepository
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
