﻿using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectBlue.RepulserEngine
{
    public abstract class ReorderableListComponentView<T> : MonoBehaviour
    {

        [SerializeField] protected Button upButton;
        [SerializeField] protected Button deleteButton;
        [SerializeField] protected Button downButton;
       
        public IObservable<Unit> OnUpButtonClickedAsObservable => upButton.OnClickAsObservable();
        public IObservable<Unit> OnDeleteButtonClickedAsObservable => deleteButton.OnClickAsObservable();
        public IObservable<Unit> OnDownButtonClickedAsObservable => downButton.OnClickAsObservable();

        public abstract void SetData(T data);

    }

}