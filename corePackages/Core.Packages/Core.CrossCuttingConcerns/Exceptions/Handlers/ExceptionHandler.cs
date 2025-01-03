﻿using Core.CrossCuttingConcerns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Handlers;

public abstract class ExceptionHandler
{
    public Task HandleExceptionAsync(Exception exception) => exception switch
    {
        BusinessException businessException => HandleException(businessException),
        _ => HandleExceptionAsync(exception), //default exception 
    };

    protected abstract Task HandleException(BusinessException businessException);
    protected abstract Task HandleException(Exception exception);
}
