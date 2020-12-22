using System;
using System.Collections.Generic;
using System.Text;

namespace VideoAppCore.Models
{
    //[2] 모델 클래스 : Video 모델 클래스 == Videos테이블과 일대일로 매칭
    // Videos => Video, VideoModel, VideoViewModel, VideoBase, VideoDto, VideoEntity, ....
    public class Video
    {
        // 일렬번호
        public int Id { get; set; }

        // 등록일
        public DateTimeOffset Created { get; set; }

        // 동영상 제목
        public string Title { get; set; }

        // 동영상 제공 URL
        public string Url { get; set; }

        // 동영상 작성자
        public string Name { get; set; }
        
        // 동영상 회사
        public string Company { get; set; }
    }
}
