﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserManagement.Models.PublicationDB
{
    public enum PublicationType
    {
        Монографія,
        Підручник,
        Навчальний_Посібник,
        Стаття,
        Інше_Наукове_Видання,
        Теза_Доповіді_На_Міжнародній_Конференції,
        Теза_Доповіді_На_Вітчизняній_Конференції,
        Патент,
        //Публікація_З_Студентами,
        Стаття_В_Закордонних_Виданнях,
        Стаття_В_Фахових_Виданнях_України,
        Стаття_В_Інших_Виданнях_України,
    }
}