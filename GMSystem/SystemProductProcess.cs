using System.Collections.Generic;

namespace ZhangM
{
    public class SystemProductProcess
    {
        private List<IComponentProductor> productors;

        public void AddProductor(Entity entity, IComponentProductor productor)
        {
            entity.AddComponent(productor);
            productors.Add(productor);
        }

        public void RemoveProductor(Entity entity, IComponentProductor productor)
        {
            entity.RemoveComponent(productor);
            productors.Remove(productor);
        }

        public void Do(ProductManager productManager)
        {
            foreach (var productor in productors)
            {
                if (productor.condition.isTrue())
                {
                    var pdt = productor.pdt;

                    productManager[pdt.type].value += pdt.value;
                }
            }
        }

        public SystemProductProcess()
        {
            productors = new List<IComponentProductor>();
        }
    }
}