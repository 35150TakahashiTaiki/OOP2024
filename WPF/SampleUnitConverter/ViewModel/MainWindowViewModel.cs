using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel :ViewModel{
        private double metricValue,imperialValue;
        //▲で呼ばれる
        public ICommand ImperialUnitToMetric { get; set; }
        //▼で呼ばれる
        public ICommand MetricToInperialUnit { get; set; }
        //上のコンボボックスで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のコンボボックスで選択されている値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                OnPropertyChanged();//値が変更されたら通知
            }
        }

        public double ImperialValue {
            get { return imperialValue; }
            set {
                this.imperialValue = value;
                OnPropertyChanged();//値が変更されたら通知
            }
        }

        //コンストラクト
        public MainWindowViewModel()
        {
            this.CurrentMetricUnit = MetricUnit.Units.First();  
            this.CurrentImperialUnit = ImperialUnit.Units.First();

            MetricToInperialUnit = new DelegateCommand(() =>ImperialValue = CurrentImperialUnit.FromMetriclUnit(CurrentMetricUnit,metricValue));
            ImperialUnitToMetric = new DelegateCommand(()=>MetricValue=CurrentMetricUnit.FromImperialUnit(CurrentImperialUnit,imperialValue));

        }

    }
}
