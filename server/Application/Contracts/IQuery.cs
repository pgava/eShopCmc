﻿using MediatR;

namespace eShopCmc.Application.Contracts;

public interface IQuery<out TResult> : IRequest<TResult>
{
}