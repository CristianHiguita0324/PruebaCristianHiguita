edaApp.factory('ImportarPlanosService', ['$resource',
  function ($resource) {
      return {
         ImportarPlanos: $resource('/services/RESTPlanossvc.svc/ImportarPlanos', {}, {
              list: { method: 'GET' }
          }),

          GenerarPlanos: $resource('/services/RESTPlanossvc.svc/GenerarPlanos', {}, {
              list: { method: 'POST' }
          }),
          
      };
  }
]);