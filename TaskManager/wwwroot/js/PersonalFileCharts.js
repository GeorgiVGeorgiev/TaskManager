function ExportMonthAndProjectCountData(MonthAndProjectCount) {
    var chartData = {
        series: [{
            name: 'Брой проекти',
            data: MonthAndProjectCount.map(function (item) { return item.projectCount; })
        }],
        xaxis: {
            categories: MonthAndProjectCount.map(function (item) { return item.monthName; })
        }
    };
    return chartData;
}

function CreateMonthAndProjectCountChartOptions(data) {
    var chartOptions = {
        chart: {
            type: 'bar',
            height: 350
        },
        colors: ['#008FFB'],
        series: data.series,
        xaxis: data.xaxis
    };
    return chartOptions;
}

function CreateMonthAndProjectCountChartOptions2(data) {
    var chartOptions = {
        chart: {
            type: 'bar',
            height: 350
        },
        colors: ['#008FFB'],
        series: data.series,
        xaxis: data.xaxis
    };
    return chartOptions;
}