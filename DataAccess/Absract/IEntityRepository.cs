using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Absract
{
    //Burada bir interface oluşturduk ve Add,Update, Delete, GetAll ve GeyById gibi tüm entitylerde kullanılan işlemleri bu interface'e ekledik.
    //Bu metotlar da parametre olarak <T> yani generik tip aldı. <T> yerine istenilen Entity gelebilir. 
    //Mesela normalde
    //void Add(Product product); yazıyorduk. Sonra gidip Categorynin data accessine de void Add(Category category); yazıyorduk. 
    //Şimdi bu yöntemle bir interface içine tüm metotları yazıp bunların herhangi bir entity almalarını sağlayacak şekilde generik tipi kullandık. Bu sayede Her entitynin data accessini bu interface'den kalıtım aldıracağız ve tekrar tekrar bunları yazmamız gerekmeyecek.
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAllByCategory(int categoryId);
    }
}
