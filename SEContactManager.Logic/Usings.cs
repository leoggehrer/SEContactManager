//@CodeCopy

#if IDINT_ON
global using IdType = System.Int32;
#elif IDLONG_ON
global using IdType = System.Int64;
#elif IDGUID_ON
global using IdType = System.Guid;
#else
global using IdType = System.Int32;
#endif
global using Common = SEContactManager.Common;
global using CommonEnums = SEContactManager.Common.Enums;
global using CommonContracts = SEContactManager.Common.Contracts;
global using CommonModels = SEContactManager.Common.Models;
global using CommonModules = SEContactManager.Common.Modules;
global using SEContactManager.Common.Extensions;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using Microsoft.EntityFrameworkCore;

