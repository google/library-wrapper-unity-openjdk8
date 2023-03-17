using Google.LibraryWrapper.Java;

namespace Java.Util
{
    public static class Extensions
    {
        public static List<T> ToJavaList<T>(
                this System.Collections.Generic.IEnumerable<T> csList)
                where T : JavaObject
        {
            ArrayList<T> result = new ArrayList<T>();
            foreach (T element in csList)
            {
                result.Add(element);
            }
            return result;
        }

        public static System.Collections.Generic.List<T> ToCsList<T>(
                this Java.Lang.Iterable<T> javaList) where T : JavaObject
        {
            System.Collections.Generic.List<T> result =
                    new System.Collections.Generic.List<T>();

            Iterator<T> iterator = javaList.Iterator();
            while (iterator.HasNext())
            {
                result.Add(iterator.Next());
            }
            return result;
        }
    }
}
