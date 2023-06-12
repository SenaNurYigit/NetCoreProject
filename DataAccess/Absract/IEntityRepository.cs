using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Absract
{
    //Burada bir interface oluşturduk ve Add,Update, Delete, GetAll ve GeyById gibi tüm entitylerde kullanılan işlemleri bu interface'e ekledik.
    //Bu metotlar da parametre olarak <T> yani generik tip aldı. <T> yerine istenilen Entity gelebilir. 
    //Mesela normalde
    //void Add(Product product); yazıyorduk. Sonra gidip Categorynin data accessine de void Add(Category category); yazıyorduk. 
    //Şimdi bu yöntemle bir interface içine tüm metotları yazıp bunların herhangi bir entity almalarını sağlayacak şekilde generik tipi kullandık. Bu sayede Her entitynin data accessini bu interface'den kalıtım aldıracağız ve tekrar tekrar bunları yazmamız gerekmeyecek.


    //Generic Constraint: Generic kısıtlama. Metoda gelecek olan T herhangi bir şey olabilir. Ama biz sadece Entity gelebilmesini istiyoruz. Bunu sağlayabilmek için yapılan kısıtlamadır.
    //Buradaki class gelen T'nin bir class olabileceğini ifade etmez. Onun bir referans tip olabileceğini ifade eder.
    //IEntity de T'nin bir IEntity veya IIEntity'den implemente edilen bir nesne olabileceğini ifade eder.
    //new() de T'nin newlenebilir olması gerektiğini ifade eder. Interface'ler implemente edilemeyeceği için buraya sadece Entityler gelebilir bu durumda.
    //Bizim DataAccessteki repositorymizin Entity nesneleri ile çalışması gerekiyor. Bu sebeple biz başka bir şeyin gelmesini engellemeye yönelik kısıtlamalar yaptık.
    public interface IEntityRepository<T> where T : class, IEntity, new() 
     {
        List<T> GetAll(Expression <Func<T,bool>> filter=null); //filter=null deyince filtre vermeyebilirsin de demektir.
        T Get(Expression<Func<T, bool>> filter); //Get işleminde bir şeye göre getireceği için filtre girme alanı var demektir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
