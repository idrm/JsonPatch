﻿namespace JsonPatchCore;

public interface IJsonPatchDocument<T> where T : class
{
    T ApplyTo(T entity);
}