using RFAB_builder.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFAB_builder
{
    static class ListExtensions
    {
        public static List<T> GetGroupByIndexes<T>(this List<T> list, List<int> indexes)
        {
            try
            {
                List<T> result = new List<T>();
                foreach (int index in indexes)
                {
                    result.Add(list[index]);
                }
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Добавляет уникальные элементы списка в список.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseList"></param>
        /// <param name="listToAdd"></param>
        /// <returns></returns>
        public static void AddUniqManyPassiveEffects(this List<IBasePassiveEffect> baseList, List<IBasePassiveEffect> listToAdd)
        {
            foreach(IBasePassiveEffect elem in listToAdd)
            {
                if (!baseList.Exists(x => x.Name == elem.Name))
                {
                    baseList.Add(elem);
                }
            }
        }

        public static void AddWithOverwriteManyPassiveEffects(this List<IBasePassiveEffect> baseList, List<IBasePassiveEffect> listToAdd)
        {
            foreach (IBasePassiveEffect elem in listToAdd)
            {
                int findedEffect = baseList.FindIndex(x => x.Type == elem.Type);
                if (findedEffect == -1)
                {
                    baseList.Add(elem);
                }
                else
                {
                    baseList[findedEffect] = elem;
                }
            }
        }

        public static void AddOverwriteSearchByName(this List<IBasePassiveEffect> baseList, IBasePassiveEffect effectToAdd)
        {
            int findedEffect = baseList.FindIndex(x => x.Name == effectToAdd.Name);
            if (findedEffect == -1)
            {
                baseList.Add(effectToAdd);
            }
            else
            {
                baseList[findedEffect] = effectToAdd;
            }
        }

        public static void AddOverwriteSearchByType(this List<IBasePassiveEffect> baseList, IBasePassiveEffect effectToAdd)
        {
            int findedEffect = baseList.FindIndex(x => x.Type == effectToAdd.Type);
            if (findedEffect == -1)
            {
                baseList.Add(effectToAdd);
            }
            else
            {
                baseList[findedEffect] = effectToAdd;
            }
        }

        public static void AddManyOverwriteSearchByType(this List<IBasePassiveEffect> baseList, List<IBasePassiveEffect> listToAdd)
        {
            baseList.RemoveAll(x => x.Type == listToAdd.Select(y => y.Type).FirstOrDefault());
            foreach (IBasePassiveEffect elem in listToAdd)
            {
                baseList.Add(elem);
            }
        }

        public static void RemoveManySearchByName(this List<IBasePassiveEffect> baseList, List<IBasePassiveEffect> listToRemove)
        {
            foreach (IBasePassiveEffect elem in listToRemove)
            {
                if (baseList.Exists(x => x.Name == elem.Name))
                    baseList.RemoveAll(x => x.Name == elem.Name);
            }
        }
    }
}
