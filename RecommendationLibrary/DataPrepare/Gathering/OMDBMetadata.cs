using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationLibrary.DataPrepare.Gathering
{
    /// <summary>
    /// 요약 :
    ///         OMDB에서 영화의 메타데이터를 수집합니다.
    /// </summary>
    public class OMDBMetadata
    {
        /// <summary>
        /// 요약 :
        ///         기본 생성자입니다.
        /// </summary>
        /// <param name="APIKey">OMDB에서 발급받은 API Key를 입력하세요.</param>
        public OMDBMetadata(string APIKey) { apiKey = APIKey; }

        /// <summary>
        /// 요약 :
        ///         OMDB에서 영화의 메타데이터를 수집하도록 실행하는 함수입니다.
        /// </summary>
        /// <param name="SrcAddress">수집할 대상을 불러올 주소</param>
        /// <param name="DestAddress">수집된 메타데이터를 저장할 주소</param>
        public void Run(string SrcAddress, string DestAddress)
        {
            loadSrcData(SrcAddress);
            saveDestData(DestAddress);
        }   // end : Run()

        private void requestMetadata() { }

        /// <summary>
        /// 요약 :
        ///         대상파일 불러오기
        /// </summary>
        /// <param name="SrcAddress">수집할 대상을 불러올 주소</param>
        private void loadSrcData(string SrcAddress)
        {
            string fileAddress;
            string[] arr_str, arr_strTok;
            FileInfo fileInfo = new FileInfo(SrcAddress);
            if (!fileInfo.Exists) { throw new FileNotFoundException(); }
            if (fileInfo.Attributes == FileAttributes.Directory) { throw new NotImplementedException(); }

            fileAddress = SrcAddress;
            arr_strTok = new string[] { ",", ":", "\t" };

            using (StreamReader sr = new StreamReader(new FileStream(fileAddress, FileMode.Open)))
            {
                while (!sr.EndOfStream)
                {
                    arr_str = sr.ReadLine().Split(arr_strTok, StringSplitOptions.None);
                }
                sr.Close();
            }
        }   // end : loadSrcData()

        /// <summary>
        /// 요약 :
        ///         수집파일 저장하기
        /// </summary>
        /// <param name="DestAddress"></param>
        private void saveDestData(string DestAddress)
        {
        }   // end : saveDestData()

        private string apiKey;
        /// <summary>
        /// 요약 :
        ///         OMDB API Key입니다.
        /// </summary>
        protected string APIKEY { get { return apiKey; } set { apiKey = value; } }
    }   // end : OMDBMetadata
}
