using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager:IWriterMessageService
    {
        IWriterMessageDal _writermessagedal;

        public WriterMessageManager(IWriterMessageDal writermessagedal)
        {
            _writermessagedal = writermessagedal;
        }

        public List<WriterMessage> GetListReciverMessage(string p)
        {
            return _writermessagedal.GetByFilter(x => x.Reciver == p);
        }

        public List<WriterMessage> GetListSendMessage(string p)
        {
            return _writermessagedal.GetByFilter(x => x.Sender == p);
        }
         
        public void TAdd(WriterMessage t)
        {
            _writermessagedal.Insert(t);    
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetByID(int id)
        {
            return _writermessagedal.GetByID(id);

        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

       

        public List<WriterMessage> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
