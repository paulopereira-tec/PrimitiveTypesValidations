namespace DotCreative.OpenSource.PrimitiveTypesValidations
{
  public static class StringExtension
  {
    /// <summary>
    /// Valida se a string é nula
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool IsNull(this string val) => val is null ? true : false;

    /// <summary>
    /// Valida se a string não é nula
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool IsNotNull(this string val) => val != null ? true : false;

    /// <summary>
    /// Valida se uma string é igual a outra
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool AreEquals(this string val, string comparer) => val == comparer ? true : false;

    /// <summary>
    /// Valida se uma string é diferente de outra
    /// </summary>
    /// <param name="val"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static bool AreNotEquals(this string val, string comparer) => val != comparer ? true : false;
  }
}
