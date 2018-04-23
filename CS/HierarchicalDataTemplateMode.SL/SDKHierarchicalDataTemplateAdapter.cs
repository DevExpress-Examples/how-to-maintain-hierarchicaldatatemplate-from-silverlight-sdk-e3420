using System.Windows;
using System.Windows.Data;

namespace HierarchicalDataTemplateMode {
    public class SDKHierarchicalDataTemplateAdapter : DevExpress.Xpf.Core.HierarchicalDataTemplate {

        public HierarchicalDataTemplate SDKTemplate { get; set; }

        public override DataTemplate GetActualTemplate() {
            return SDKTemplate;
        }

        public override Binding GetActualItemSource() {
            if(SDKTemplate != null)
                return SDKTemplate.ItemsSource;
            return null;
        }

        public override DataTemplate GetActualItemTemplate() {
            if(SDKTemplate != null)
                return SDKTemplate.ItemTemplate;
            return null;
        }
    }
}