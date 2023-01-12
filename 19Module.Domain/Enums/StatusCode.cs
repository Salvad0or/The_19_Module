namespace _19Module.Domain.Enums
{
    /// <summary>
    /// Здесь мы указываем кастомные ошибки 
    /// </summary>
    public enum StatusCode
    {
        Ok = 200,
        PersonNotFound = 0,
        SomeError = 1,
        ICantAddPerson = 2,
        CantEditPerson = 3,
        CantDeletePerson = 4,

    }
}