// Task

function Task(result) {
  this._continuations = isValue(result) ?
                          (this.status = 'done', null) :
                          (this.status = 'pending', []);
  this.result = result;
  this.error = null;
}
var Task$ = {
  get_completed: function() {
    return this.status != 'pending';
  },
  continueWith: function(continuation) {
    if (this._continuations) {
      this._continuations.push(continuation);
    }
    else {
      var self = this;
      setTimeout(function() { continuation(self); }, 0);
    }
    return this;
  },
  done: function(callback) {
    return this.continueWith(function(t) {
      if (t.status == 'done') {
        callback(t.result);
      }
    });
  },
  fail: function(callback) {
    return this.continueWith(function(t) {
      if (t.status == 'failed') {
        callback(t.error);
      }
    });
  },
  then: function(doneCallback, failCallback) {
    return this.continueWith(function(t) {
      t.status == 'done' ? doneCallback(t.result) : failCallback(t.error);
    });
  }
};

function _updateTask(task, result, error) {
  if (task.status == 'pending') {
    if (error) {
      task.error = error;
      task.status = 'failed';
    }
    else {
      task.result = result;
      task.status = 'done';
    }

    var continuations = task._continuations;
    task._continuations = null;

    for (var i = 0, c = continuations.length; i < c; i++) {
      continuations[i](task);
    }
  }
}

function _joinTasks(tasks, any) {
  tasks = toArray(tasks);

  var count = tasks.length;

  var interval = 0;
  if ((count > 1) && (typeof tasks[0] == 'number')) {
    interval = tasks[0];
    tasks = tasks.slice(1);
    count--;
  }

  var joinTask = new Task();
  var seen = 0;

  function continuation(t) {
    if (joinTask.status == 'pending') {
      seen++;
      if (any) {
        _updateTask(joinTask, t);
      }
      else if (seen == count) {
        _updateTask(joinTask, true);
      }
    }
  }

  function timeout() {
    if (joinTask.status == 'pending') {
      if (any) {
        _updateTask(joinTask, null);
      }
      else {
        _updateTask(joinTask, false);
      }
    }
  }

  if (interval != 0) {
    setTimeout(timeout, interval);
  }

  for (var i = 0; i < count; i++) {
    tasks[i].continueWith(continuation);
  }

  return joinTask;
}
Task.all = function() {
  return _joinTasks(arguments, false);
}
Task.any = function() {
  return _joinTasks(arguments, true);
}
Task.delay = function(timeout) {
  var timerTask = new Task();

  setTimeout(function() {
    _updateTask(timerTask, true);
  }, timeout);

  return timerTask;
}

function deferred(result) {
  var task = new Task(result);

  return {
    task: task,
    resolve: function(result) {
      _updateTask(task, result);
    },
    reject: function(error) {
      _updateTask(task, null, (error || new Error()));
    }
  };
}

