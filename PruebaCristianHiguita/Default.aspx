<%@ Page Title="" Language="C#" MasterPageFile="~/MasterView.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PruebaCristianHiguita.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="menu" ng-class="(menuopen?'open':'')">
        <div id="title" style="height: 70px;">
            <h6><span ng-show="menuopen">  <h6 class="par">
           
         </h6>
               
                 <a id="menu-close" ng-click="menuopen=false; menustatic=false"><i class="fa fa-close"></i></a></span></h6>
            
            <h2><a id="menu-open" ng-click="menuopen=true; menustatic=true" ng-show="!menuopen"><i class="fa fa-bars"></i></a> </h2>
        </div>
        <div>
            <ul id="tree">
              <li>
                    <a class="li-body" href="#"><i class="fa fa-home"></i><span style="z-index: 1;">&nbsp;Inicio</span></a>
                </li>
                <li>
                    <a class="li-body" href="#planos"><i class="fa fa-user"></i><span ng-show="menuopen">&nbsp;Planos</span></a>
                </li>
           
             </ul>

        </div>
     
    </div>
    


    <div id="body" ng-class="(menustatic?'open':'')">
       
        <div ng-view></div>
     </div>


</asp:Content>

