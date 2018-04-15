function receiverInterceptor($q) {
    return {
        request: function (config) {
            config.headers = config.headers || {};
            // insert code to populate your request header for instance

            if (config.data) {
                //console.log('request nuevo', config);
                config.data = dateJSToNet(config.data);
            }
            return config;
        },
        response: function (response) {
            if (response.status === 403 || response.status === 401) {
                // insert code to redirect to custom unauthorized page
            }
            response.data = dateNetToJS(response.data);
            //console.log('response nuevo', response);
            return response || $q.when(response);
        }
    };
}
function dateNetToJS(data) {
    for (var i in data) {
        if (i.indexOf('$') == 0)
            continue;
        var d = data[i];
        if (!d)
            continue;
        if (typeof d == 'string') {
            if (d.indexOf('/Date(') != -1) {
                var date = new Date(parseInt(d.substr(6)));
                data[i] = date;
            }
        }
        else if (typeof d == 'object') {
            dateNetToJS(d);
        }
    }
    return data;
}
function dateJSToNet(data) {
    for (var i in data) {
        if (i.indexOf('$') == 0)
            continue;
        var d = data[i];
        if (!d)
            continue;

        if (d instanceof Date) {
            console.log(d);
            console.log(d.getTime());

            data[i] = '/Date(' + d.getTime() + '-0500)/';
        }
        else if (typeof d == 'object') {
            console.log(i, d);
            //dateJSToNet(d);
        }
    }
    return data;
}