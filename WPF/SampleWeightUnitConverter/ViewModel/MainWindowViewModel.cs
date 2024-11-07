using SampleWeightUnitConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWeightUnitConverter {
    public class MainWindowViewModel :ViewModel{
        private double gramValue,poundValue;
        //▲で呼ばれる
        public ICommand PoundUnitToGram { get; set; }
        //▼で呼ばれる
        public ICommand GramToPoundUnit { get; set; }
        //上のコンボボックスで選択されている値
        public GramUnit CurrentGramUnit { get; set; }
        //下のコンボボックスで選択されている値
        public PoundUnit CurrentPoundlUnit { get; set; }

        public double GramValue {
            get { return this.gramValue; }
            set {
                this.gramValue = value;
                OnPropertyChanged();//値が変更されたら通知
            }
        }

        public double PoundValue {
            get { return poundValue; }
            set {
                this.poundValue = value;
                OnPropertyChanged();//値が変更されたら通知
            }
        }

        //コンストラクト
        public MainWindowViewModel()
        {
            this.CurrentGramUnit = GramUnit.Units.First();  
            this.CurrentPoundlUnit = PoundUnit.Units.First();

            GramToPoundUnit = new DelegateCommand(() => PoundValue = CurrentPoundlUnit.FromGramUnit(CurrentGramUnit, gramValue));
            PoundUnitToGram = new DelegateCommand(()=> GramValue = CurrentGramUnit.FromPoundUnit(CurrentPoundlUnit, poundValue));

        }

    }
}
