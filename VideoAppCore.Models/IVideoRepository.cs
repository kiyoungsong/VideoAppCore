using System.Collections.Generic;
using System.Text;

namespace VideoAppCore.Models
{

    // [3] 인터페이스 : Videos 테이블에 대한 CRUD API 명세서 작성
    public interface IVideoRepository
    {
        Video AddVideo(Video model);    // 입력 : T Add(T model);
        List<Video> GetVideos();        // 출력 : List<T> GetALL();
        Video GetVideoById(int id);     // 상세 : GetById(int id);
        Video UpdateVideo(Video model); // 수정 : T Edit(T model);
        void RemoveVideo(int id);       // 삭제 : void Delete(int id);
    }


    // CRUD와 관련된 메서드 이름
    // Add, Get, Update, Remove 등의 단어를 많이 사용한다.
}
