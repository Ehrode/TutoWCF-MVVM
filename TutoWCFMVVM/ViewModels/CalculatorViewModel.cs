using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TutoWCFMVVM.com.dneonline.www;
using TutoWCFMVVM.Models;

namespace TutoWCFMVVM.ViewModels
{
    public class CalculatorViewModel: INotifyPropertyChanged
    {

        public List<SymbolAction> SymbolActionList = new List<SymbolAction>
        {
            new SymbolAction("+", "Add"),
            new SymbolAction("-", "Subtract"),
            new SymbolAction("*", "Multiply"),
            new SymbolAction("/", "Divide"),

        };

        public Calculator CalculatorInstance = new Calculator();
        

        private SymbolAction _selectedSymbolAction;
        public SymbolAction SelectedSymbolAction
        {
            get
            {
                return _selectedSymbolAction;
            }
            set
            {
                _selectedSymbolAction = value;
                NotifyPropertyChanged("SelectedSymbolAction");
                CalculateResult();
            }
        }

        private int _leftMember;
        public int LeftMember
        {
            get
            {
                return _leftMember;
            }
            set
            {
                if (value != _leftMember)
                {
                    _leftMember = value;
                    NotifyPropertyChanged("LeftMember");
                    CalculateResult();
                }
            }
        }

        private int _rightMember;
        public int RightMember
        {
            get
            {
                return _rightMember;
            }
            set
            {
                if (value != _rightMember)
                {
                    _rightMember = value;
                    NotifyPropertyChanged("RightMember");
                    CalculateResult();
                }
            }
        }

        private int _operationResult;
        public int OperationResult
        {
            get
            {
                return _operationResult;
            }
            set
            {
                if (value != _operationResult)
                {
                    _operationResult = value;
                    NotifyPropertyChanged("OperationResult");
                }
            }
        }
        
        private void CalculateResult()
        {
            var test1 = SelectedSymbolAction.ActionName;
            var test = typeof(Calculator).GetMethod(SelectedSymbolAction.ActionName);
            try
            {
                OperationResult = (int)typeof(Calculator).GetMethod(SelectedSymbolAction.ActionName)?.Invoke(CalculatorInstance, new object[] { LeftMember, RightMember });
            }
            catch
            {
                OperationResult = 0;
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
