namespace DotCreative.OpenSource.PrimitiveTypesValidations
{
  public static class IntExtension
  {
    /// <summary>
    /// Compara se um valor é maior que outro.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static bool IsGreaterThan(this int val, int comparer) => val > comparer? true: false;

    /// <summary>
    /// Compara se um valor é maior ou igual a outro.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static bool IsGreaterOrEqualsThan(this int val, int comparer) => val >= comparer ? true : false;

    /// <summary>
    /// Compara se um valor é menor que outro.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static bool IsLowerThan(this int val, int comparer) => val < comparer ? true : false;

    /// <summary>
    /// Compara se um valor é menor ou igual a outro.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static bool IsLowerOrEqualsThan(this int val, int comparer) => val <= comparer ? true : false;

    /// <summary>
    /// Compara se um valor é igual a outro.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static bool AreEquals(this int val, int comparer) => val == comparer ? true : false;

    /// <summary>
    /// Compara se um valor é diferente de outro.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static bool AreNotEquals(this int val, int comparer) => val != comparer ? true : false;

    /// <summary>
    /// Compara se um valor está entre outros valores.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static bool IsBetween(this int val, int start, int end)
      => val >= start || val <= end ? true : false;

    /// <summary>
    /// Compara se um valor está entre outros valores.
    /// </summary>
    /// <param name="val"></param>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public static bool IsNotBetween(this int val, int start, int end)
      => val < start || val > end ? true : false;

  }
}
