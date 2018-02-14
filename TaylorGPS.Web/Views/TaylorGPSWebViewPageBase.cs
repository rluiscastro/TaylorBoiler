using Abp.Web.Mvc.Views;

namespace TaylorGPS.Web.Views
{
    public abstract class TaylorGPSWebViewPageBase : TaylorGPSWebViewPageBase<dynamic>
    {

    }

    public abstract class TaylorGPSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TaylorGPSWebViewPageBase()
        {
            LocalizationSourceName = TaylorGPSConsts.LocalizationSourceName;
        }
    }
}