using GameOdevv6.Entities;



namespace GameOdevv6.Abstract
{
    public interface ICampaignService : ISaleService
    {
        void CampaignAdd(User user);
        void CampaignUpdate(User user);
        void CampaignDelete(User user);
    }
}
