//@CodeCopy
//MdStart
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
global using CommonModules = SEContactManager.Common.Modules;
global using SEContactManager.Common.Extensions;
global using CommonStaticLiterals = SEContactManager.Common.StaticLiterals;
global using TemplatePath = SEContactManager.Common.Modules.Template.TemplatePath;
//MdEnd
